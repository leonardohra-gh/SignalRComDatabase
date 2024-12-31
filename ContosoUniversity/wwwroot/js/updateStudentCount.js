"use strict";

// Configurar a conexão com o hub
var connection = new signalR.HubConnectionBuilder().withUrl("/studentsHub").build();

// Começar a conexão com o hub
connection.start().then(function () {
    console.log("Conexão feita")
}).catch(function (err) {
    return console.error(err.toString());
});

// Caso a gente receba um sinal de UpdateStudentCount (que vai ser chamado no método StudentsHub.AddStudent ou StudentsHub.RemoveStudent)
// Mude a quantidade de alunos para a nova quantidade
connection.on("UpdateStudentCount", function (newAmount) {
    document.getElementById("studentAmount").textContent = newAmount;
});