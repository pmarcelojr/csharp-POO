### Problema exemplo

Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço mínimo seja 100.

### Predicate (System)
- Representa um método que recebe um objeto do tipo T e retorna um valor booleano
```
public delegate bool Predicate<in T>(T obj);
```