### Patch release → fix: → 1.0.1

```bash
git commit -m "fix: corregir bug en el cálculo del interés compuesto"
```
Resultado

 - Versión sube de 1.0.0 → 1.0.1

 - Sección en changelog: Bug fixes

### Minor release → feat: → 1.1.0

```bash
git commit -m "feat: agregar soporte para exportar a PDF"
```
Resultado

 - Versión sube de 1.0.0 → 1.1.0

 - Sección en changelog: New features

### Major release (breaking change) → feat!: o BREAKING CHANGE: → 2.0.0

Opción A: con ! en el tipo
```bash
git commit -m "feat!: eliminar soporte para .NET 5.0"
```
Opción B: con BREAKING CHANGE: en el cuerpo
```bash
git commit -m "feat: reestructurar configuración de base de datos" \
  -m "BREAKING CHANGE: se cambió la forma en que se inicializa el contexto de datos."
```
Resultado

 - Versión sube de 1.0.0 → 2.0.0

 - Sección en changelog: New features, con aviso de BREAKING CHANGES al final.


## Extra: otros tipos útiles (no afectan versión)


 | Tipo        | Efecto            | Ejemplo                                            |
| ----------- | ----------------- | -------------------------------------------------- |
| `docs:`     | No cambia versión | `docs: actualizar README`                          |
| `chore:`    | No cambia versión | `chore: actualizar dependencias`                   |
| `refactor:` | No cambia versión | `refactor: simplificar lógica de login`            |
| `test:`     | No cambia versión | `test: agregar pruebas para validación de usuario` |
