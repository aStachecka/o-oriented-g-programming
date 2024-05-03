using administrator_wydarzen.Models;
using administrator_wydarzen.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace administrator_wydarzen.Presenters
{
    class MainPresenter
    {
        private Views.Form1 _view;
        private Models.EventList _model;
        private ColumnHeader _lastClickedHeader;
        private System.Windows.Forms.SortOrder _sortOrder = System.Windows.Forms.SortOrder.Ascending;

        public MainPresenter(Views.Form1 view, Models.EventList model)
        {
            _view = view;
            _model = model;
            _view.AddEvent += _view_AddEvent;
            _view.SelectEvent += _view_SelectEvent;
            _view.DeleteEvent += _view_DeleteEvent;
            _view.ColumnHeaderClicked += _view_ColumnHeaderClicked;
        }

        private Form1 _form;

        public MainPresenter(Form1 form)
        {
            _form = form;
        }

        private void _view_AddEvent()
        {
            if (String.IsNullOrEmpty(_view.getTitle()) || String.IsNullOrEmpty(_view.getDescription()) || String.IsNullOrEmpty(_view.getType()))
            {
                MessageBox.Show("Pola nie mogą być puste!");
            }
            else
            {
                Event eve = new Event(_view.getTitle(), _view.getDescription(), _view.getDate, _view.getType(), _view.getPriority());
                _view.eventlist.list.Add(eve);
                _view.addToListView();
            }
        }
        private void _view_SelectEvent(int index)
        {
            if (index >= 0 && index < _form.lvEvents.Items.Count)
            {
                var selectedItem = _form.lvEvents.Items[index];
                string title = selectedItem.SubItems[0].Text;
                string description = selectedItem.SubItems[1].Text;
                DateTime date = DateTime.Parse(selectedItem.SubItems[2].Text);
                string type = selectedItem.SubItems[3].Text;
                string priority = selectedItem.SubItems[4].Text;

                _view.setFormValues(title, description, date, type, priority);
            }
        }


        private void _view_DeleteEvent(int index)
        {
            if (index >= 0 && index < _view.lvEvents.Items.Count)
            {
                _view.lvEvents.Items.RemoveAt(index);
            }
        }

        private void _view_ColumnHeaderClicked(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader clickedHeader = _view.lvEvents.Columns[e.Column];

            if (clickedHeader == _lastClickedHeader)
            {
                _sortOrder = _sortOrder == System.Windows.Forms.SortOrder.Ascending ? System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                _sortOrder = System.Windows.Forms.SortOrder.Ascending;
                _lastClickedHeader = clickedHeader;
            }

            _view.SortItems(e.Column, _sortOrder);
        }
    }
}

