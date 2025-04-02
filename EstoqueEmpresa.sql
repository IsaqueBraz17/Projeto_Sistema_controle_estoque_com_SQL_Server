CREATE DATABASE Estoque_Empresa;
GO

USE Estoque_Empresa;
GO

-- Tabela Produtos
CREATE TABLE TBLPRODUTOS(
    ID_Produto INT IDENTITY(1,1) PRIMARY KEY,  
    Nome_Produto NVARCHAR(100) NOT NULL, 
    Categoria_Produto NVARCHAR(50) NOT NULL, 
    Fornecedor_Produto NVARCHAR(100) NOT NULL, 
    Quantidade_Produto INT NOT NULL DEFAULT 0,
    Preco_Produto DECIMAL(10,2) NOT NULL DEFAULT 0.00, 
    Status_Produto VARCHAR(20) NOT NULL, 
    Localizacao_Produto VARCHAR(50), 
    Data_Adicao DATE NOT NULL DEFAULT GETDATE()
);

-- Tabela Fornecedores
CREATE TABLE TBLFORNECEDR(
    ID_Fornecedor INT IDENTITY(1,1) PRIMARY KEY,  
    Nome_Fornecedor NVARCHAR(100) NOT NULL, 
    Contato_Fornecedor NVARCHAR(50), 
    Cidade_Fornecedor NVARCHAR(50), 
    Pais_Fornecedor NVARCHAR(50), 
    Categoria_Fornecedor NVARCHAR(50)
);

-- Tabela Clientes
CREATE TABLE TBLCLIENTES(
    ID_Cliente INT IDENTITY(1,1) PRIMARY KEY,  
    Nome_Cliente NVARCHAR(100) NOT NULL, 
    Contato_Cliente NVARCHAR(50), 
    Cidade_Cliente NVARCHAR(50), 
    Pais_Cliente NVARCHAR(50), 
    CPF_Cliente NVARCHAR(14) UNIQUE, 
    Email_Cliente NVARCHAR(100) UNIQUE
);


-- SELECTs para cada tabela
SELECT * FROM TBLPRODUTOS;
SELECT * FROM TBLFORNECEDR;
SELECT * FROM TBLCLIENTES;