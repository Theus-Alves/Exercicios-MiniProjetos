**Relatório: Exemplo Avançado de Integração do Python com o SQLite**

**Objetivo:**
O objetivo deste código é demonstrar uma integração avançada entre o Python e o SQLite, um banco de dados leve e embutido. O exemplo abrange a criação de uma conexão com o banco de dados, criação de uma tabela, inserção de dados, consulta, atualização e exclusão de registros na tabela.

**Descrição do Código:**
O código começa importando a biblioteca `sqlite3`, que fornece uma interface Python para o SQLite. Em seguida, é criada uma conexão com o banco de dados utilizando o método `connect`, passando o nome do arquivo de banco de dados como parâmetro.

Após a conexão ser estabelecida, é executada uma instrução SQL para criar uma tabela chamada "produtos" com colunas para "id", "nome" e "preco". A instrução `CREATE TABLE IF NOT EXISTS` é utilizada para criar a tabela apenas se ela não existir.

Em seguida, são inseridos dados na tabela utilizando a instrução `INSERT INTO`. Três registros são inseridos na tabela "produtos" com nomes e preços fictícios.

Após a inserção dos dados, é realizada uma consulta utilizando a instrução `SELECT`. Os resultados são percorridos utilizando um cursor e cada registro é impresso na saída.

O código também inclui exemplos de atualização e exclusão de registros na tabela. Utilizando as instruções `UPDATE` e `DELETE`, é possível atualizar o preço de um produto e excluir um produto da tabela.

Por fim, é realizada uma nova consulta para exibir os dados atualizados na tabela.

**Conclusão:**
A integração do Python com o SQLite oferece uma solução leve e eficiente para armazenar e manipular dados em um banco de dados embutido. O exemplo apresentado demonstra a criação de uma conexão