# Task Manager

<p align="center">
    <img src="https://hermes.digitalinnovation.one/companies/32ac7d05-cb69-4a11-a756-bddfeed69256.png" width="250px"/>
</p>

<p align="center">
    <img alt="test" src="https://img.shields.io/badge/language-csharp-green">
    <img alt="test" src="https://img.shields.io/badge/frame-net-pink">
    <img alt="test" src="https://img.shields.io/badge/container-docker-blue">
    <img alt="test" src="https://img.shields.io/badge/orm-entityframework-red">
    <img alt="test" src="https://img.shields.io/badge/db-sqlserver-orange">
</p>

## About:

Development of a restful api application performing operations for the sales sector.

Being organized by salespeople, products and sales made, all salespeople have specific products, where the last task (sale) will be performed and monitored by the customer, but there is no form of authentication, we only use the logic for the test.

## Layout:

<img src="../Assets/test-doc.png"/>

Image result can be seen on my linkedin - publications:
[mateusmaciel340](https://www.linkedin.com/in/mateusmaciel340/)

## How to run the project?

The steps to access the project are very simple, but follow in the following order:

```bash
docker-compose up -d #01

build dotnet #02

dotnet-ef migrations add MigrationsInitial #03

dotnet-ef database update #04

dotnet watch run #05
```

## Technologies

The following tools were used in building the project:

### Backend (C#)

- C#
- .Net
- Docker
- EntityFramework
- SqlServer

## Contributors

<table>
    <thead>
        <tr>
            <td>
                <img src="https://avatars.githubusercontent.com/u/55550732?v=4" width="150px"/>
            </td>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>Mateus Maciel</th>
        </tr>
    </tbody>
</table>

## How to contribute?

1. Fork the project.
2. Create a new branch with your changes: `git checkout -b my-feature`
3. Save the changes and create a commit message telling what you did: `git commit -m Modifying this [...]`
4. Submit your changes: `git push origin my-feature`

## License

This project is under license [MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt).