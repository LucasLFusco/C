-- Tabela de Clinetes:
CREATE TABLE cliente(
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    data_nasc DATE NOT NULL,
    cpf VARCHAR(11) NOT NULL UNIQUE
); 

-- Tabela de Carros:
CREATE TABLE veiculo(
    placa VARCHAR(7) PRIMARY KEY,
    fabricante VARCHAR(10) NOT NULL,
    modelo VARCHAR(20) NOT NULL,
    ano INT NOT NULL,
    cor VARCHAR(15) NOT NULL
); 

-- Tabela de locações
CREATE TABLE locacao(
	nr_locacao INT PRIMARY KEY AUTO_INCREMENT,
	id_cliente INT NOT NULL,
	placa VARCHAR(7) NOT NULL,
	data_locacao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
		CONSTRAINT fk_locacao_cliente FOREIGN KEY (id_cliente)
		REFERENCES cliente(id_cliente),
		CONSTRAINT fk_locacao_veiculo FOREIGN KEY (placa)
		REFERENCES veiculo(placa)
);

