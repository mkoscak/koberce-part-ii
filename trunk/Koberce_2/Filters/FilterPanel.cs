using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Koberce_2.Filters
{
    public partial class FilterPanel : UserControl
    {
        Control lastAdded;
        List<FilterItem> items;
        EventHandler handler;

        public FilterPanel(Control parent, EventHandler eh)
        {
            InitializeComponent();

            this.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
                        | System.Windows.Forms.AnchorStyles.Left
                        | System.Windows.Forms.AnchorStyles.Right);

            this.SetBounds(0, 0, parent.Width, parent.Height);
            
            flowLayout.ControlAdded += new ControlEventHandler(flowLayout_ControlAdded);

            items = new List<FilterItem>();
            handler = eh;

            //BackColor = Color.AntiqueWhite;
        }

        public string GetSQL(string op)
        {
            List<string> conditions = new List<string>();

            foreach (var item in items)
            {
                var cond = item.FormatSQL();
                if (!string.IsNullOrEmpty(cond))
                    conditions.Add(cond);
            }

            var ret = string.Join(op, conditions.ToArray());
            return string.IsNullOrEmpty(ret) ? null : ret;
        }

        void flowLayout_ControlAdded(object sender, ControlEventArgs e)
        {
            lastAdded = e.Control;
        }

        public void AddFilter(FilterItemType itemType, string columnName, string title)
        {
            items.Add(new FilterItem(columnName, itemType));
            Control c;

            switch (itemType)
            {
                case FilterItemType.BOOLEAN:
                    var cb = AddFilter<CheckBox>(columnName, title);
                    cb.CheckedChanged += handler;
                    c = cb;
                    break;

                case FilterItemType.NUMBER:
                case FilterItemType.TEXT:
                default:
                    var tb = AddFilter<TextBox>(columnName, title);
                    tb.TextChanged += handler;
                    c = tb;
                    break;
            }

            items.Last().Control = c;
        }

        public T AddFilter<T>(string name, string title)
            where T : Control, new()
        {
            T item = new T();
            Label label = new Label();

            if (typeof(T) == typeof(CheckBox))
            {
                label = null;
                item.Text = title;
                item.Margin = new Padding(10, 4, 10, 4);
                (item as CheckBox).AutoSize = true;
                (item as CheckBox).Checked = true;
                (item as CheckBox).UseVisualStyleBackColor = true;
                item.ForeColor = SystemColors.HotTrack;
            }
            if (typeof(T) == typeof(DateTimePicker))
            {
                (item as DateTimePicker).ShowCheckBox = true;
                (item as DateTimePicker).Checked = false;
                (item as DateTimePicker).Format = DateTimePickerFormat.Custom;
                (item as DateTimePicker).CustomFormat = "dd.MM.yyyy HH:mm";
                (item as DateTimePicker).Size = new Size(150, item.Size.Height);
            }
            if (typeof(T) == typeof(Button))
            {
                label = null;
                item.Text = title;
                (item as Button).UseVisualStyleBackColor = true;
            }
            if (typeof(T) == typeof(GroupBox))
            {
                label = null;
                item.Text = title;

                var fp = new TableLayoutPanel();
                fp.Dock = DockStyle.Fill;
                fp.ColumnCount = 1;
                //fp.FlowDirection = FlowDirection.TopDown;
                (item as GroupBox).Controls.Add(fp);
            }

            if (item == null)
                return item;

            if (label != null)
            {
                label.Text = title;
                label.TextAlign = ContentAlignment.MiddleRight;
                label.AutoSize = true;
                label.Margin = new Padding(3, 5, 0, 5);
                label.ForeColor = SystemColors.HotTrack;
            }

            // pridanie poloziek do flow layoutu
            FlowLayoutPanel p = new FlowLayoutPanel();
            p.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            p.AutoSize = true;
            p.Controls.Add(label);
            p.Controls.Add(item);
            p.Margin = new Padding(0,0,0,0);
            this.flowLayout.Controls.Add(p);

            ToolTip t = new ToolTip();
            t.SetToolTip(item, title);

            item.Name = name;
            item.Tag = name;
        

            return item;
        }

        public void LineBreak()
        {
            if (lastAdded == null)
                return;

            flowLayout.SetFlowBreak(lastAdded, true);
        }
    }

    public enum FilterItemType
    {
        TEXT,
        NUMBER,
        BOOLEAN
    }
}
