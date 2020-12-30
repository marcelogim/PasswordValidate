# PasswordValidate (Versão Alpha)
Esta API é um validador de senhas baseado no guia "Repo do desafio de backend".

https://github.com/itidigital/backend-challenge

## Documentação da REST API

Foi utilizando o stoplight para desenho da API, em Open Api 3.0.

[https://github.com/marcelogim/PasswordValidate/blob/main/PasswordValidate.v1.yaml](https://github.com/marcelogim/PasswordValidate/blob/main/PasswordValidate.v1.yaml)

## Funcionamento

O sistema consiste em validar uma senha em string "password", esta validação se da por meio de um regex e retorna um json, sendo válido ou não "isValid".

Request true:

```
curl -X POST \
  http://localhost:5000/passwordValidate \
  -H 'cache-control: no-cache' \
  -H 'content-type: application/json' \
  -d '{
	"password" : "Admin@123"
}'
```

Response true:

```
{
    "isValid": true
}
```

Request true:

```
curl -X POST \
  http://localhost:5000/passwordValidate \
  -H 'cache-control: no-cache' \
  -H 'content-type: application/json' \
  -d '{
	"password" : "Admin@122"
}'
```

Response false:

```
{
    "isValid": false
}
```
## Regras

As regras abaixo foram codificadas para validar senhas e esta refletido no contrato de APIs:

1 - Nove ou mais caracteres

2 - Ao menos 1 dígito

3 - Ao menos 1 letra minúscula

4 - Ao menos 1 letra maiúscula

5 - Ao menos 1 caractere especial

    Considere como especial os seguintes caracteres: !@#$%^&*()-+
    Não possuir caracteres repetidos dentro do conjunto
    
 Para construir a aplicação foi utilizando uma REGEXP para validação das regras acima, esta regexp esta representada abaixo e foi escrita em C# - .net Core 3.1.
 "^(?!.*(.).*\1)(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{9,15}$ 

## InfoContact
Marcelo França

marcelogim@gmail.com

