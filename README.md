
## Description

 - The `Track` field in the `Session` model is non-nullable.

 - When the `SessionType` uses a resolver the `Track` field is nullable.

   ![Session Type using a Resolver](Images/with-resolver.png)

 - When the `SessionType` doesn't use a resolver the `Track` field is non-nullable as defined on the model.

   ![Session Type without a Resolver](Images/without-resolver.png)

 - When the `SessionType` uses a resolver and we force the nullability with a `.Type` decoration the `Track` field is non-nullable.

   ![Session Type using a Resolver and Type decoration](Images/with-resolver-with-type-decoration.png)

