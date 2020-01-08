using PegsiApp.Models;
using PegsiApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PegsiApp.ViewModels
{
    class ParticipanteViewModel : BaseViewModel
    {

        private DataService _dataService = new DataService();
        public Participante _participante;

        public Participante Participante
        {
            get { return _participante; }
            set 
            {
                _participante = value;
                OnPropertyChanged();
            }
        }

        public ParticipanteViewModel()
        {
            Title = "Participante";

            //GetParticipantes();
        }

        //private async Task GetParticipantes()
        //{
        //    Participante = await _dataService.GetParticipanteAsync(9);
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
