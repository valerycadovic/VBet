using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model
{
    public interface IUpdater
    {
        /// <summary>
        /// Обновляет базу данных
        /// </summary>
        /// <returns></returns>
        Task UpdateStorageAsync();

        bool IsActive { get; }

        /// <summary>
        /// Событие, происходящее при завершении работы парсера
        /// </summary>
        event Action<object> OnCompleted;
    }
}
