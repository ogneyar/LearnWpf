
using System.Windows;
using LearnWpf.Infrastucture.Commands.Base;

namespace LearnWpf.Infrastucture.Commands
{
    internal class CloseAplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
