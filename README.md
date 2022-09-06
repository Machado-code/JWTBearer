# JWTBearer / Swagger
WEB API ASP.NET / .NET 6.0 / JwtBearer (Autenticação e Autorização)

<!---Esses são exemplos. Veja https://shields.io para outras pessoas ou para personalizar este conjunto de escudos. Você pode querer incluir dependências, status do projeto e informações de licença aqui--->

![GitHub repo size](https://img.shields.io/github/repo-size/Machado-code/JWTBearer?style=for-the-badge)
![Version](https://img.shields.io/docker/v/Machado-code/JWTBearer?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/Machado-code/JWTBearer?style=for-the-badge)
![GitHub forks](https://img.shields.io/github/forks/Machado-code/JWTBearer?style=for-the-badge)
![Bitbucket open issues](https://img.shields.io/bitbucket/issues/Machado-code/JWTBearer?style=for-the-badge)
![Bitbucket open pull requests](https://img.shields.io/bitbucket/pr-raw/Machado-code/JWTBearer?style=for-the-badge)
![GitHub contributors](https://img.shields.io/github/contributors/Machado-code/JWTBearer?style=for-the-badge)

> Sistema WEB API Autenticacao e Autorizacao com JWTBearer

## :technologist: Técnologia / Padões Utilizado
- C#
- WEB Api (Interface de programação de aplicação servidor/navegador)
- .Net Core v6.0 (Framework livre e de codigo aberto)
- JWT Bearer Authentication / Authorization
- Swagger

## 💻 Pré-requisitos

Antes de começar, verifique se você atendeu aos seguintes requisitos:
<!---Estes são apenas requisitos de exemplo. Adicionar, duplicar ou remover conforme necessário--->
* Visual Studio 2022 Instalado
* Você tem uma máquina `<Windows / Linux / Mac>`.

## ☕ Usando o JWTBearer

Para usar o JWTBearer, siga estas etapas:

Com o JWTBearer aberto no Visual Studio 2022:
- Clicar em: **Depurar > Iniciar Depuração**
<br/>Ou
- Clicar na tecla **F5** com o projeto/solução já aberto.
- Abrirá uma pagina WEB de seu navegador padrão com a execução do JWTBearer na pagina do Swagger. 

![image](https://user-images.githubusercontent.com/51836378/188522032-4ca4925e-464f-418e-8258-3706de703b88.png)

Para uso efetuar a Autenticacao temos dois usuarios exemplos em Hard-Code. Localizado no arquivo UserRepository.cs

```
  public static User Get(string username, string password)
  {
      var users = new List<User>();
      users.Add(new User { Id = 1, Username = "goku", Password = "goku", Role = "manager" });
      users.Add(new User { Id = 2, Username = "vegeta", Password = "vegeta", Role = "employee" });
      return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
  }
```

Utilizando o Username e Password em api/Home/login com o metodo POST

![image](https://user-images.githubusercontent.com/51836378/188522514-fab7c152-d564-4a14-886f-7733a6e01be0.png)

Tera o seguinte retorno contendo o Token JWT

![image](https://user-images.githubusercontent.com/51836378/188522554-b9816b8c-91d8-44d2-b3ab-6376415eba5c.png)

Copiar Token e inserir em Authorize do Swagger, iniciando com Bearer {Seu Token}.

![image](https://user-images.githubusercontent.com/51836378/188522687-c3ec1772-c7c8-41bc-ba48-a49fd2c3dcf6.png)


## 📫 Contribuindo
<!---Se o seu README for longo ou se você tiver algum processo ou etapas específicas que deseja que os contribuidores sigam, considere a criação de um arquivo CONTRIBUTING.md separado--->
Para contribuir, siga estas etapas:

1. Bifurque este repositório.
2. Crie um branch: `git checkout -b <nome_branch>`.
3. Faça suas alterações e confirme-as: `git commit -m '<mensagem_commit>'`
4. Envie para o branch original: `git push origin <nome_do_projeto> / <local>`
5. Crie a solicitação de pull.

Como alternativa, consulte a documentação do GitHub em [como criar uma solicitação pull](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/creating-a-pull-request).

## 🤝 Colaboradores

Agradecemos às seguintes pessoas que contribuíram para este projeto:

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/matheus-code" target="_blank">
        <img src="https://chingizpro.github.io/portfolio/img/person.png" width="100px;"/><br>
        <sub>
          <b>Matheus Machado</b>
        </sub>
      </a>
    </td>
  </tr>
</table>


## 📝 Licença

Esse projeto está sob licença. Veja o arquivo [LICENÇA](LICENSE.md) para mais detalhes.
