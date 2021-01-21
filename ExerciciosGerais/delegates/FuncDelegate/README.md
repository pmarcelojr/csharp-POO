### Problema exemplo

Fazer um programa  que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em caixa alta.

### Func (System)
- Representa um método que recebe zero ou mais argumentos, e retorna um valor.
```
public delegate TResult Func<out TResult>();
public delegate TResult Func<in T, out TResult>(T obj);
public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
(16 Sobrecargas)
```