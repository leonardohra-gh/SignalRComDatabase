using Microsoft.AspNetCore.SignalR;

namespace ContosoUniversity.Hubs
{
    public class StudentsHub() : Hub
    {
        // Criar o método que deve mandar o sinal para todos os clientes
        public async Task UpdateStudentCount(int newAmount)
        {
            await Clients.All.SendAsync("UpdateStudentCount", newAmount);
        }
    }
}
