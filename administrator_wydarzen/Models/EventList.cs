using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace administrator_wydarzen.Models
{
    public class EventList
    {
        public List<Event> list = new List<Event>();
        public List<Event> filtered = new List<Event>();

        public void Serialize()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik XML|*.xml|Wszystkie pliki|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Event>));
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    xml.Serialize(fileStream, list);
                }
            }
        }

        public void Deserialize()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                list.Clear();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Event>), new XmlRootAttribute("ArrayOfEvent"));
                using (Stream reader = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    var x = (List<Event>)serializer.Deserialize(reader);
                    foreach (Event p in x)
                    {
                        list.Add(p);
                    }
                }
            }
        }

        public void Sort()
        {
            // Implement sorting logic
        }

        public void Filter(string filter, string value)
        {
            // Implement filtering logic
        }

        public void Filter(string filter, DateTime value)
        {
            // Implement filtering logic
        }

        public EventList()
        {
            // Inicjalizacja listy wydarzeń, jeśli to konieczne
        }

    }
}
