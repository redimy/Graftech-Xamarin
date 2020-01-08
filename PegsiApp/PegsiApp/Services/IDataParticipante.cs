using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PegsiApp.Services
{
    public interface IDataParticipante<T>
    {
        Task<bool> AddParticipanteAsync(T item);
        Task<bool> UpdateParticipanteAsync(T item);
        Task<bool> DeleteParticipanteAsync(string id);
        Task<T> GetParticipanteAsync(int id);
        Task<IEnumerable<T>> GetParticipantesAsync();

        //Task<IEnumerable<T>> GetParticipantesAsync(bool forceRefresh = false);
    }
}
