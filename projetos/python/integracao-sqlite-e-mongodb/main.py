import sqlite3

# Criar uma conexão com o banco de dados
conn = sqlite3.connect('exemplo.db')

# Criar uma tabela
conn.execute('''CREATE TABLE IF NOT EXISTS produtos
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                nome TEXT NOT NULL,
                preco REAL NOT NULL)''')

# Inserir dados na tabela
conn.execute("INSERT INTO produtos (nome, preco) VALUES ('Produto 1', 10.99)")
conn.execute("INSERT INTO produtos (nome, preco) VALUES ('Produto 2', 15.99)")
conn.execute("INSERT INTO produtos (nome, preco) VALUES ('Produto 3', 19.99)")

# Realizar consulta no banco de dados
cursor = conn.execute("SELECT * FROM produtos")
for row in cursor:
    print(f"ID: {row[0]}, Nome: {row[1]}, Preço: {row[2]}")

# Atualizar dados na tabela
conn.execute("UPDATE produtos SET preco = 12.99 WHERE id = 1")

# Deletar dados da tabela
conn.execute("DELETE FROM produtos WHERE id = 2")

# Realizar consulta atualizada no banco de dados
cursor = conn.execute("SELECT * FROM produtos")
for row in cursor:
    print(f"ID: {row[0]}, Nome: {row[1]}, Preço: {row[2]}")

# Fechar a conexão com o banco de dados
conn.close()
