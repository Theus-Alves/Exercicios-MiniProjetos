# Relatório - Sistema de Cadastro de Funcionários

O código fornecido implementa um programa básico em C# para um sistema de cadastro de funcionários. Ele se conecta a um banco de dados no Azure usando o `System.Data.SqlClient` e realiza a inserção de dados na tabela "Funcionarios".

## Descrição do Código

O programa segue a seguinte sequência de passos:

1. Configura a string de conexão com o banco de dados do Azure.
2. Realiza a conexão com o banco de dados usando a classe `SqlConnection`.
3. Solicita informações do usuário, como nome, cargo e salário do funcionário.
4. Cria uma consulta SQL para inserir os dados na tabela "Funcionarios".
5. Executa a consulta usando a classe `SqlCommand` e obtém o número de linhas afetadas.
6. Exibe uma mensagem informando o sucesso da inserção ou, caso ocorra algum erro, exibe uma mensagem de erro.
7. Fecha a conexão com o banco de dados.

## Resultados

O programa é executado em linha de comando e interage com o usuário para obter as informações do funcionário a ser cadastrado. Após a inserção dos dados na tabela, uma mensagem é exibida informando o número de linhas afetadas.

Caso ocorra algum erro durante a inserção, uma mensagem de erro é exibida, fornecendo informações sobre o problema.

## Conclusão

O código implementa um sistema simples de cadastro de funcionários, utilizando a biblioteca `System.Data.SqlClient` para se conectar a um banco de dados do Azure. Ele demonstra como realizar a inserção de registros em uma tabela específica, fornecendo uma base para o desenvolvimento de funcionalidades mais avançadas.

É importante ressaltar que o código fornecido é um exemplo básico e pode ser expandido e aprimorado para atender a requisitos adicionais do sistema de cadastro de funcionários.

