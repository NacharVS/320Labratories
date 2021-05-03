using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using XmlDgWPF.Model;
using RandomNameGenerator;

namespace XmlDgWPF.ViewModel
{
    public class SettingsVM : BaseVM
    {
        private ICommand addCommand, saveCommand, removeCommand;

        public void Add(object p = null)
        {

            if (All.Count == 0)
            {           
                All.Add(new Student { ID = 1,
                                    FirstName = NameGenerator.GenerateFirstName(0).ToLowerInvariant(),
                                    Last = NameGenerator.GenerateLastName(), Age = 16,
                                    Gender = 0 });
            }
            else
            {            
                All.Add(new Student { ID = All.Max(x => x.ID) + 1,
                                    FirstName = NameGenerator.GenerateFirstName(0),
                                    Last = NameGenerator.GenerateLastName(),
                                    Age = 16,
                                    Gender = 0 });
            }
        }

        public void Save(object p = null)
        {
            Student.Save(Settngs.Path, All.ToArray());
        }

        public void Remove(object p)
        {
            var col = (p as IList<object>).Cast<Student>().ToArray();

            foreach (var x in col)
            {
                All.Remove(x);
            }
        }

        public SettingsVM(IEnumerable<Student> all)
        {
            All = new ObservableCollection<Student>(all);
            addCommand = new RelayCommand(Add);
            saveCommand = new RelayCommand(Save);
            removeCommand = new RelayCommand(Remove);
        }

        public SettingsVM() : this(Student.Load(Settngs.Path))
        {

        }

        public ObservableCollection<Student> All { get; private set; }

        public ICommand AddCommand
        {
            get { return addCommand; }
            set { addCommand = value; }
        }
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        public ICommand RemoveCommand
        {
            get { return removeCommand; }
            set { removeCommand = value; }
        } 
    }    
}