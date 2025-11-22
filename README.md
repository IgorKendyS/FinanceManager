# Como começar
1. Inicialize o projeto uma vez antes dos testes, isso irá fazer criar a conta admin.
2. Feche o programa e rode o teste "SeedDatabaseWithRandomData"
## Atenção
É necessário seguir essa ordem pois a condição para criar o admin é apenas se a tabela de usuários estiver vazia.
Outros pontos de atenção:
- Os testes de inserir usuário na tabela (TestInsertUsers) estão sem a criptografia de senha, impossibilitando de logar com essas contas.
