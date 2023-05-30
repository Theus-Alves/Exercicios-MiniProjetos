from flask import Flask, jsonify, request

app = Flask(__name__)

# Dados de exemplo
livros = [
    {'id': 1, 'titulo': 'Livro 1', 'autor': 'Autor 1'},
    {'id': 2, 'titulo': 'Livro 2', 'autor': 'Autor 2'},
    {'id': 3, 'titulo': 'Livro 3', 'autor': 'Autor 3'}
]

# Rota para a raiz da API
@app.route('/')
def hello():
    return 'Bem-vindo à API Flask!'

# Rota para obter todos os livros
@app.route('/livros', methods=['GET'])
def get_livros():
    return jsonify(livros)

# Rota para obter um livro por ID
@app.route('/livros/<int:livro_id>', methods=['GET'])
def get_livro(livro_id):
    livro = next((livro for livro in livros if livro['id'] == livro_id), None)
    if livro:
        return jsonify(livro)
    else:
        return jsonify({'mensagem': 'Livro não encontrado'}), 404

# Rota para adicionar um novo livro
@app.route('/livros', methods=['POST'])
def add_livro():
    novo_livro = {
        'id': request.json['id'],
        'titulo': request.json['titulo'],
        'autor': request.json['autor']
    }
    livros.append(novo_livro)
    return jsonify(novo_livro), 201

# Rota para atualizar um livro existente
@app.route('/livros/<int:livro_id>', methods=['PUT'])
def update_livro(livro_id):
    livro = next((livro for livro in livros if livro['id'] == livro_id), None)
    if livro:
        livro['titulo'] = request.json.get('titulo', livro['titulo'])
        livro['autor'] = request.json.get('autor', livro['autor'])
        return jsonify(livro)
    else:
        return jsonify({'mensagem': 'Livro não encontrado'}), 404

# Rota para deletar um livro existente
@app.route('/livros/<int:livro_id>', methods=['DELETE'])
def delete_livro(livro_id):
    livro = next((livro for livro in livros if livro['id'] == livro_id), None)
    if livro:
        livros.remove(livro)
        return jsonify({'mensagem': 'Livro removido com sucesso'})
    else:
        return jsonify({'mensagem': 'Livro não encontrado'}), 404

# Execução da API
if __name__ == '__main__':
    app.run(debug=True)
