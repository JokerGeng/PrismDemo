using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo
{
    public class ContentViewModel:BindableBase
    {
        public ContentViewModel()
        {
            content = "ContentViewModel";
            Pub = new DelegateCommand(PubCommand);
            PubStr = new DelegateCommand<string>(PubCommandStr);
        }

        private string content;

        public DelegateCommand Pub { get; set; }
        public DelegateCommand<string> PubStr { get; set; }

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                RaisePropertyChanged(Content);
            }
        }

        private void PubCommand()
        {

            Console.WriteLine("PubCommand");
        }

        private void PubCommandStr(string str)
        {
            Console.WriteLine(str);
        }
    }
}
