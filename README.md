# PasswordValidate (Versão Alpha)
Esta API é um validador de senhas baseado no guia Repo do desafio de backend.
https://github.com/itidigital/backend-challenge

## Documentação da REST API

[https://github.com/marcelogim/PasswordValidate/blob/main/PasswordValidate.v1.yaml](https://github.com/marcelogim/PasswordValidate/blob/main/PasswordValidate.v1.yaml)

## Funcionamento

O sistema consiste em validar uma senha em string "password", esta validação se da por meio de um regex e retorna um json se é válido ou não isValid.

```
POST /passwordValidate HTTP/1.1
Host: localhost:5000
Content-Type: application/json
{
	"password" : "Admin@123"
}
```
## Regras

As regras abaixo foram codificadas para validar senhas e esta refletido no contrato de APIs

1 - Nove ou mais caracteres
2 - Ao menos 1 dígito
3 - Ao menos 1 letra minúscula
4 - Ao menos 1 letra maiúscula
5 - Ao menos 1 caractere especial
    Considere como especial os seguintes caracteres: !@#$%^&*()-+
    Não possuir caracteres repetidos dentro do conjunto

##### InfoContact
Marcelo França
marcelogim@gmail.com

