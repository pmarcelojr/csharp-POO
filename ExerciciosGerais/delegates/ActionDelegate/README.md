### Problema exemplo

Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos 10%;

### Action (System)
- Representa um metodo void que recebe zero ou mais argumentos
````
public delegate void Action();
public delegate void Action<in T>(T obj);
public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
(16 sobrecargas)
```