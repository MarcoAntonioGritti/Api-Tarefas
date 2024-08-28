# 📝 Api-Tarefas

Bem-vindo à **Api-Tarefas**! 🚀  
Esta API foi desenvolvida em C# e oferece um **CRUD completo** para o gerenciamento de tarefas.  
É totalmente aberta, então sinta-se à vontade para usá-la e modificá-la como desejar! 🌟

---

## 📚 Endpoints

Aqui estão os endpoints disponíveis na API:

| Método | Endpoint                      | Descrição                          |
|--------|--------------------------------|------------------------------------|
| `POST` | `/AdicionarTarefa`             | ➕ Adicionar uma nova tarefa        |
| `PUT`  | `/AtualizarTarefa/{id}`        | ✏️ Atualizar uma tarefa existente   |
| `DELETE`| `/DeletarTarefa/{id}`         | 🗑️ Deletar uma tarefa               |
| `GET`  | `/ObterPorId/{id}`             | 🔍 Obter uma tarefa por ID          |
| `GET`  | `/ObterPorStatus/{status}`     | 📝 Obter tarefas por Status         |
| `GET`  | `/ObterPorData/{data}`         | 📅 Obter tarefas por Data           |
| `GET`  | `/ObterPorNome/{nome}`         | 🔤 Obter tarefas por Nome           |
| `GET`  | `/ListarTarefas`               | 📜 Listar todas as tarefas          |

---

## 🛠️ Pacotes Utilizados

Este projeto foi construído utilizando os seguintes pacotes:

- `Microsoft.EntityFrameworkCore.SqlServer`  
- `Microsoft.EntityFrameworkCore.Tools`  
- `Microsoft.EntityFrameworkCore.Design`

---

## 🚀 Como Usar

Siga os passos abaixo para clonar e executar o projeto em sua máquina:

1. **Clone o repositório**:
- git clone https://github.com/seu-usuario/Api-Tarefas.git
2. **Navegue até o diretório do projeto:**
- cd Api-Tarefas
3. **Crie uma nova branch (para não afetar a branch principal):**
- git checkout -b sua-branch
4. **Instale as dependências:**
- dotnet restore
5. **Execute as migrações para configurar o banco de dados:**
- dotnet ef database update

🤝 Contribuição
Contribuições são bem-vindas!
Sinta-se à vontade para fazer um fork, criar uma branch, e enviar um pull request. Toda ajuda é apreciada! 💪
