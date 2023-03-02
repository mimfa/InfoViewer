using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MiMFa.Service;
using System.Linq;
using MiMFa.Exclusive.Animate;
using System.Collections;
using MiMFa.Engine.Template;

namespace MiMFa.UIL.InfoViewer
{
    public partial class ListViewer : Form
    {
        public FormMove MFM = new FormMove();
        public MiMFa.Exclusive.View.ToText Convertor = new Exclusive.View.ToText();

        public MiMFa.Engine.Template.ITemplator Theme { get; }

        public ListViewer()
        {
            InitializeComponent();
            Init(Color.White,Color.DimGray,"Properties",true);
        }
        public ListViewer(string address, string label = "Properties")
        {
            InitializeComponent();
            Init(Color.White, Color.DimGray, label, string.IsNullOrWhiteSpace(address));
            SetInfo(address);
        }
        public ListViewer(string address, MiMFa.Engine.Template.ITemplator theme, string label = "Properties")
        {
            InitializeComponent();
            Theme = theme;
            Init(Theme.Palette.BackColor, Theme.Palette.ForeColor, label, string.IsNullOrWhiteSpace(address));
            Theme.Update(this,10,true, InfoGrid);
            SetInfo(address);
        }
        public ListViewer(string address, Color backcolor, Color forecolor, string label = "Properties")
        {
            InitializeComponent();
            Init(backcolor, forecolor, label, string.IsNullOrWhiteSpace(address));
            SetInfo(address);
        }
        public ListViewer(IEnumerable<KeyValuePair<object, object>> kvps, Color backcolor, Color forecolor, string label = "Properties")
        {
            InitializeComponent();
            Init(backcolor, forecolor, label,false);
            SetInfo(kvps.ToArray());
        }
        public ListViewer(IEnumerable<KeyValuePair<object, object>> kvps, string label = "Properties")
        {
            InitializeComponent();
            Init(BackColor, ForeColor, label, false);
            SetInfo(kvps.ToArray());
        }
        public ListViewer(IEnumerable<KeyValuePair<object, object>> kvps, MiMFa.Engine.Template.ITemplator theme, string label = "Properties")
        {
            InitializeComponent();
            Theme = theme;
            Init(Theme.Palette.BackColor, Theme.Palette.ForeColor, label, false);
            Theme.Update(this, 10, true, InfoGrid);
            SetInfo(kvps.ToArray());
        }
        public ListViewer(object obj, Color backcolor, Color forecolor, string label = "Properties")
        {
            InitializeComponent();
            Init(backcolor, forecolor, label, false);
            SetInfo(obj);
        }
        public ListViewer(object obj, ITemplator theme, string label = "Properties")
        {
            InitializeComponent();
            Theme = theme;
            Init(Theme.Palette.BackColor, Theme.Palette.ForeColor, label, false);
            Theme.Update(this, 10, true, InfoGrid);
            SetInfo(obj);
        }

        private void Init(Color backcolor, Color forecolor, string label = "Properties", bool changeable = false)
        {
            API.Initialize();
            l_GetFileInfo.Text = label;
            p_Open.Visible = changeable;
            if (Theme == null)
            {
                if (backcolor != Color.Empty) BackColor = tb_SelectPath.BackColor = btn_Done.ForeColor = backcolor;
                if (forecolor != Color.Empty) ForeColor = tb_SelectPath.ForeColor = btn_Done.BackColor = forecolor;
            }
            MFM.MainControl = this;
            MFM.AddToControl(l_GetFileInfo);
        }

        public DialogResult ShowDialog(string address, string label = "Properties")
        {
            Init(BackColor, ForeColor, label, string.IsNullOrWhiteSpace(address));
            SetInfo(address);
            return ShowDialog();
        }
        public DialogResult ShowDialog(string address, Color backcolor, Color forecolor, string label = "Properties")
        {
            Init(BackColor, ForeColor, label, string.IsNullOrWhiteSpace(address));
            SetInfo(address);
            return ShowDialog();
        }
        public DialogResult ShowDialog(IEnumerable<KeyValuePair<object, object>> kvps, string label = "Properties")
        {
            Init(BackColor, ForeColor, label, false);
            SetInfo(kvps.ToArray());
            return ShowDialog();
        }
        public DialogResult ShowDialog(IEnumerable<KeyValuePair<object, object>> kvps, Color backcolor, Color forecolor, string label = "Properties")
        {
            Init(backcolor, forecolor, label, false);
            SetInfo(kvps.ToArray());
            return ShowDialog();
        }
        public DialogResult ShowDialog(object obj,  string label = "Properties")
        {
            Init(BackColor, ForeColor, label, false);
            SetInfo(obj);
            return ShowDialog();
        }
        public DialogResult ShowDialog(object obj, Color backcolor, Color forecolor, string label = "Properties")
        {
            Init(backcolor, forecolor, label, false);
            SetInfo(obj);
            return ShowDialog();
        }

        public void Show(string address, string label = "Properties")
        {
            Init(BackColor, ForeColor, label, string.IsNullOrWhiteSpace(address));
            SetInfo(address);
            Show();
        }
        public void Show(string address, Color backcolor, Color forecolor, string label = "Properties")
        {
            Init(BackColor, ForeColor, label, string.IsNullOrWhiteSpace(address));
            SetInfo(address);
            Show();
        }
        public void Show(IEnumerable<KeyValuePair<object, object>> kvps,  string label = "Properties")
        {
            Init(BackColor, ForeColor, label, false);
            SetInfo(kvps.ToArray());
            Show();
        }
        public void Show(IEnumerable<KeyValuePair<object, object>> kvps, Color backcolor, Color forecolor, string label = "Properties")
        {
            Init(backcolor, forecolor, label, false);
            SetInfo(kvps.ToArray());
            Show();
        }
        public void Show(object obj, string label = "Properties")
        {
            Init(BackColor, ForeColor, label, false);
            SetInfo(obj);
            Show();
        }
        public void Show(object obj, Color backcolor, Color forecolor, string label = "Properties")
        {
            Init(backcolor, forecolor, label, false);
            SetInfo(obj);
            Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SelectPath_Click(object sender, EventArgs e)
        {
            SetInfo((tb_SelectPath.Text =
                InfoService.IsFile(tb_SelectPath.Text, false) ?
                    DialogService.OpenFile(tb_SelectPath.Text) :
                        InfoService.IsDirectory(tb_SelectPath.Text, false) ?
                            DialogService.OpenDirectory(tb_SelectPath.Text)
                            : string.IsNullOrWhiteSpace(tb_SelectPath.Text) ?
                                DialogService.OpenFile()
                                : tb_SelectPath.Text));
        }
        private void SetInfo(string address)
        {
            if (!string.IsNullOrWhiteSpace(address))
                try
                {
                    tb_SelectPath.Text = address;
                    if (InfoService.IsFile(address))
                        SetFileInfo(address);
                    else if(InfoService.IsDirectory(address))
                        SetDirectoryInfo(address);
                    else
                        SetWebsiteInfo(address);
                }
                catch(Exception ex) { DialogService.ShowMessage(ex); }
            else InfoGrid.Rows.Clear();
        }
        private void SetInfo(object obj)
        {
            if (obj != null)
                if (obj is IEnumerable)
                    try
                    {
                        int i = 0;
                        List<KeyValuePair<object, object>> lo = new List<KeyValuePair<object, object>>();
                        foreach (var v in (IEnumerable)obj)
                            lo.Add(new KeyValuePair<object, object>(i++, v));
                        SetInfo(lo.ToArray());
                        return;
                    }
                    catch (Exception ex)
                    {
                    }
                else try
                    {
                        var ps = obj.GetType().GetProperties();
                        if (ps.Length > 0)
                        {
                            SetInfo((from v in ps select new KeyValuePair<object, object>(v.Name, v.GetValue(obj))).ToArray());
                            return;
                        }
                    }
                    catch
                    {
                    }
            try { SetInfo(new KeyValuePair<object, object>(l_GetFileInfo.Text, obj)); }
            catch { }
        }
        private void SetInfo(params KeyValuePair<object, object>[] kvps)
        {
            InfoGrid.Rows.Clear();
            foreach (var item in kvps)
                InfoGrid.Rows[InfoGrid.Rows.Add(Convertor.Done(item.Key), Convertor.Done(item.Value))].Tag = item.Value;
        }
        private void SetFileInfo(string address)
        {
            FileInfo fi = new FileInfo(address);

            SetInfo(new KeyValuePair<object, object>("Attributes:", fi.Attributes.ToString()),
            new KeyValuePair<object, object>("Name:", fi.Name),
            new KeyValuePair<object, object>("Extension:", fi.Extension),
            new KeyValuePair<object, object>("Exists:", fi.Exists),
            new KeyValuePair<object, object>("Is Read Only:", fi.IsReadOnly),
            new KeyValuePair<object, object>("Length:", ConvertService.ToUniversalUnit(fi.Length,2,"","B")),
            new KeyValuePair<object, object>("Directory:", fi.Directory),
            new KeyValuePair<object, object>("Directory Name:", fi.DirectoryName),
            new KeyValuePair<object, object>("Full Name:", fi.FullName),
            new KeyValuePair<object, object>("Creation Date:", fi.CreationTime.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Creation Time:", fi.CreationTime.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Creation Date Utc:", fi.CreationTimeUtc.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Creation Time Utc:", fi.CreationTimeUtc.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Access Date:", fi.LastAccessTime.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Access Time:", fi.LastAccessTime.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Access Date Utc:", fi.LastAccessTimeUtc.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Access Time Utc:", fi.LastAccessTimeUtc.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Write Date:", fi.LastWriteTime.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Write Time:", fi.LastWriteTime.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Write Date Utc:", fi.LastWriteTimeUtc.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Write Time Utc:", fi.LastWriteTimeUtc.GetDateTimeFormats()[30]));
        }
        private void SetDirectoryInfo(string address)
        {
            DirectoryInfo fi = new DirectoryInfo(address);

            SetInfo(new KeyValuePair<object, object>("Attributes:", fi.Attributes.ToString()),
            new KeyValuePair<object, object>("Name:", fi.Name),
            new KeyValuePair<object, object>("Extension:", fi.Extension),
            new KeyValuePair<object, object>("Exists:", fi.Exists),
            new KeyValuePair<object, object>("Sub Directories:", Directory.GetDirectories(address).Length),
            new KeyValuePair<object, object>("Full Name:", fi.FullName),
            new KeyValuePair<object, object>("Creation Date:", fi.CreationTime.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Creation Time:", fi.CreationTime.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Creation Date Utc:", fi.CreationTimeUtc.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Creation Time Utc:", fi.CreationTimeUtc.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Access Date:", fi.LastAccessTime.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Access Time:", fi.LastAccessTime.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Access Date Utc:", fi.LastAccessTimeUtc.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Access Time Utc:", fi.LastAccessTimeUtc.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Write Date:", fi.LastWriteTime.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Write Time:", fi.LastWriteTime.GetDateTimeFormats()[30]),
            new KeyValuePair<object, object>("Last Write Date Utc:", fi.LastWriteTimeUtc.GetDateTimeFormats()[0]),
            new KeyValuePair<object, object>("Last Write Time Utc:", fi.LastWriteTimeUtc.GetDateTimeFormats()[30]));

        }
        private void SetWebsiteInfo(string address)
        {
            Uri fi = new Uri(address);

            SetInfo(new KeyValuePair<object, object>("Attributes:", (fi.IsFile?"File ":"") + "Url"),
            new KeyValuePair<object, object>("Dns Safe Host:", fi.DnsSafeHost),
            new KeyValuePair<object, object>("Is Well Uri:", InternetService.IsWellURL(address)),
            new KeyValuePair<object, object>("Port:", fi.Port),
            new KeyValuePair<object, object>("Host:", fi.Host),
            new KeyValuePair<object, object>("Query:", fi.Query),
            new KeyValuePair<object, object>("Original:", fi.OriginalString.ToString()),
            new KeyValuePair<object, object>("Absolute Uri:", fi.AbsoluteUri),
            new KeyValuePair<object, object>("Local Path:", fi.LocalPath),
            new KeyValuePair<object, object>("Scheme:", fi.Scheme));
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            string path = DialogService.SaveFile(l_GetFileInfo.Text + ".Info");
            if (!string.IsNullOrEmpty(path))
                try
                {
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    for (int i = 0; i < InfoGrid.Rows.Count; i++)
                        sw.WriteLine(InfoGrid.Rows[i].Cells[0].Value + ":\t" + InfoGrid.Rows[i].Cells[1].Value);
                    sw.Close();
                }
                catch (Exception ex) { DialogService.ShowMessage(ex, true); }
        }

        private void ShowInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            API.Finalize();
        }
        private void dgv_fileinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > InfoGrid.Rows.Count || InfoGrid.Rows[e.RowIndex].Tag == null) return;
            (new ListViewer(InfoGrid.Rows[e.RowIndex].Tag,BackColor,ForeColor, InfoGrid.Rows[e.RowIndex].Cells[dgv_tb_Name.Name].Value+"")).ShowDialog();
        }
    }
}
