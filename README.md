# GitExercise

Console calculator used for the "Git in practice" lab. Three developers worked on separate
branches (`Dev-A`, `Dev-B`, `Dev-C`) that were merged into `master`, resolving conflicts.

## Run

```
dotnet run --project GitExercise
```

The app asks for a password first (`abcd1234`), then repeats calculations until you choose `e`.

## Options

| Key  | Operation                      | Branch |
| ---- | ------------------------------ | ------ |
| `a`  | Add                            | base   |
| `s`  | Subtract                       | base   |
| `m`  | Multiply                       | base   |
| `d`  | Divide                         | Dev-A  |
| `sa` | Subtract, absolute value       | Dev-A  |
| `r`  | Remainder                      | Dev-B  |
| `p`  | Power (a ^ b)                  | Dev-C  |
| `l`  | Logarithm (log of a, base b)   | Dev-C  |
| `f`  | Sum of two factorials (a!+b!)  | Dev-C  |
| `e`  | Exit                           | Dev-B  |
