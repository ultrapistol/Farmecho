CREATE TABLE logins (
email varchar(50),
senha varchar(15)
)

SELECT * FROM logins;

INSERT INTO logins (email, senha)
VALUES ('joao@gmail.com', '12345');