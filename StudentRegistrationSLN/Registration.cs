using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSLN
{
    class Registration
    {
        private string _filePath = "student.json";

        public int Id { get; set;}

        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string ProgramEnroll { get; set; }

        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; }

        public void Add(Registration info)
        {
            Random random = new Random();
            info.Id = random.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);

        }

        public Registration Edit(int id)
        {

            Registration obj = new Registration();
            return obj;
        }

        public void Edit(Registration info)
        {
            List<Registration> list = List();
            Registration registration = list.Where(x => x.Id == info.Id).FirstOrDefault();
            list.Remove(registration);
            list.Add(info);
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filePath, data, false);
        }

        public void Delete(int id)
        {
            List<Registration> list = List();
            Registration registration = list.Where(x => x.Id == id).FirstOrDefault();
            list.Remove(registration);
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            int cnt = list.Count;
            Utility.WriteToTextFile(_filePath, data, false, cnt);

        }

        public Registration Detail(int id)
        {
            Registration obj = new Registration();
            return obj;
        }

        public List<Registration> List()
        {
            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
                List<Registration> lst = JsonConvert.DeserializeObject<List<Registration>>(d);
                return lst;
            }
            return null;
        }

    }
}
