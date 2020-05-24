using Newtonsoft.Json;
using PegsiApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PegsiApp.Services
{
    public class DataService : IDataParticipante<Participante>
    {
        private string Url = "http://gruma.mindlink.mx:85/api/participantes/";

        public async Task<IEnumerable<Participante>> GetParticipantesAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var participantes = JsonConvert.DeserializeObject<List<Participante>>(json);

            return participantes;
        }

        public async Task<Participante> GetParticipanteAsync(int id)
        {
            var httpClient = new HttpClient();
            try
            {
                var json = await httpClient.GetStringAsync(Url + id + "/documentos");
                var participante = JsonConvert.DeserializeObject<Participante>(json);
                return participante;
            }
            catch
            {
                return null;
            }

        }


        public Task<bool> AddParticipanteAsync(Participante item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteParticipanteAsync(string id)
        {
            throw new NotImplementedException();
        }

      
        public Task<bool> UpdateParticipanteAsync(Participante item)
        {
            throw new NotImplementedException();
        }
    }
}
