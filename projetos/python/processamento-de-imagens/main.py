# arquivo: meu_pacote_imagens.py

import numpy as np
import matplotlib.pyplot as plt

def carregar_imagem(caminho):
    """
    Carrega uma imagem a partir de um arquivo e retorna um objeto numpy array.
    """
    imagem = plt.imread(caminho)
    return imagem

def exibir_imagem(imagem):
    """
    Exibe uma imagem na janela de plotagem.
    """
    plt.imshow(imagem)
    plt.axis('off')
    plt.show()

def converter_para_escala_cinza(imagem):
    """
    Converte uma imagem colorida em escala de cinza.
    """
    imagem_gray = np.dot(imagem[...,:3], [0.2989, 0.5870, 0.1140])
    return imagem_gray

def redimensionar_imagem(imagem, largura, altura):
    """
    Redimensiona uma imagem para a largura e altura especificadas.
    """
    imagem_redimensionada = plt.imresize(imagem, (altura, largura))
    return imagem_redimensionada

def salvar_imagem(imagem, caminho):
    """
    Salva uma imagem em um arquivo.
    """
    plt.imsave(caminho, imagem)
