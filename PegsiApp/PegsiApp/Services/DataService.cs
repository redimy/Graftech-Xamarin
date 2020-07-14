using GraftechApp.Dtos;
using Newtonsoft.Json;
using PegsiApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PegsiApp.Services
{
    public class DataService : IDataParticipante<ParticipanteDto>
    {
        private string Url = "http://gruma.mindlink.mx:85/api/participantes/";
        //private string Url = "https://localhost:5001/api/participantes/";

        public async Task<IEnumerable<ParticipanteDto>> GetParticipantesAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var participantes = JsonConvert.DeserializeObject<List<ParticipanteDto>>(json);

            return participantes;
        }

        public async Task<ParticipanteDto> GetParticipanteAsync(int id)
        {
            var httpClient = new HttpClient();
            try
            {
                var json = await httpClient.GetStringAsync(Url + id + "/documentos");
                var participante = JsonConvert.DeserializeObject<ParticipanteDto>(json);
                return participante;
            }
            catch(Exception ex)
            {
                return null;
            }

        }


        public Task<bool> AddParticipanteAsync(ParticipanteDto item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteParticipanteAsync(string id)
        {
            throw new NotImplementedException();
        }

      
        public Task<bool> UpdateParticipanteAsync(ParticipanteDto item)
        {
            throw new NotImplementedException();
        }
    }
}
