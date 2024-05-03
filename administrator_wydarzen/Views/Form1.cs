using administrator_wydarzen.Models;
using administrator_wydarzen.Presenters;
using administrator_wydarzen.Views;
using System;
using System.Collections.Generic;
using System.Linq;


using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace administrator_wydarzen.Views
{
    public partial class Form1 : Form
    {
        public EventList eventlist = new EventList();
        public event EventHandler<ColumnClickEventArgs> ColumnHeaderClicked;

        public Form1()
        {
            InitializeComponent();
            lvEvents.ColumnClick += (sender, e) => ColumnHeaderClicked?.Invoke(sender, e);
        }

        public event Action AddEvent;
        public event Action<int> SelectEvent;
        public event Action<int> DeleteEvent;

        public void selectEvent(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView listView = (System.Windows.Forms.ListView)sender;
            if (listView.SelectedItems.Count == 1)
            {
                int selectedIndex = listView.SelectedIndices[0];
                if (selectedIndex >= 0 && selectedIndex < listView.Items.Count)
                {
                    var selectedItem = listView.Items[selectedIndex];
                    string title = selectedItem.SubItems[0].Text;
                    string description = selectedItem.SubItems[1].Text;
                    DateTime date = DateTime.Parse(selectedItem.SubItems[2].Text);
                    string type = selectedItem.SubItems[3].Text;
                    string priority = selectedItem.SubItems[4].Text;

                    tbTitle.Text = title;
                    tbDesc.Text = description;
                    dateTimePicker.Value = date;
                    cbType.Text = type;
                    cbPriority.Text = priority;
                }
            }
        }


        public void addToListView()
        {
            lvEvents.Items.Clear();
            foreach (var x in eventlist.list)
            {
                ListViewItem item = new ListViewItem(x.Title);
                item.SubItems.Add(x.Description);
                item.SubItems.Add(x.Date.ToShortDateString());
                item.SubItems.Add(x.Type);
                item.SubItems.Add(x.Priority);
                lvEvents.Items.Add(item);
            }
        }

        public void setFormValues(string title, string description, DateTime date, string type, string priority)
        {
            tbTitle.Text = title;
            tbDesc.Text = description;
            dateTimePicker.Value = date;
            cbType.Text = type;
            cbPriority.Text = priority;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            lvEvents.Items.Clear();
            eventlist.Deserialize();
            addToListView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            eventlist.Serialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvEvents.SelectedItems.Count > 0)
            {
                int index = lvEvents.SelectedIndices[0];
                DeleteEvent?.Invoke(index);
            }
        }

        public void SortItems(int columnIndex, SortOrder order)
        {
            lvEvents.ListViewItemSorter = new ListViewItemComparer(columnIndex, order);
            lvEvents.Sort();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEvent?.Invoke();
        }

        public string getTitle()
        {
            return tbTitle.Text;
        }

        public string getDescription()
        {
            return tbDesc.Text;
        }

        public string getType()
        {
            return cbType.Text;
        }

        public string getPriority()
        {
            return cbPriority.Text;
        }

        public DateTime getDate
        {
            get
            {
                return dateTimePicker.Value;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedPriority = cbPriorFilter.SelectedItem?.ToString();
            string selectedType = cbTypeFilter.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePickerFilter.Value.Date;

            List<Event> filteredEvents = eventlist.list.Where(ev =>
            {
                bool priorityMatch = string.IsNullOrEmpty(selectedPriority) || ev.Priority == selectedPriority;
                bool typeMatch = string.IsNullOrEmpty(selectedType) || ev.Type == selectedType;
                bool dateMatch = ev.Date.Date == selectedDate;

                return priorityMatch && typeMatch && dateMatch;
            }).ToList();

            UpdateListView(filteredEvents);
        }


        private void UpdateListView(List<Event> events)
        {
            lvEvents.Items.Clear();
            foreach (var ev in events)
            {
                ListViewItem item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Description);
                item.SubItems.Add(ev.Date.ToShortDateString());
                item.SubItems.Add(ev.Type);
                item.SubItems.Add(ev.Priority);
                lvEvents.Items.Add(item);
            }
        }
    }
}
