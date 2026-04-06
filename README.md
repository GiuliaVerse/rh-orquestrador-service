# RH Orquestrador Service

Serviço em **.NET 8** que recebe chamadas do frontend ou de outros serviços e aciona a Azure Function.

## Responsabilidade
- iniciar processamento de documento enviado
- iniciar verificação de documento vencendo
- servir como camada de integração com Azure Functions

## Endpoints principais (PT-BR)
- `POST /api/processamentos/documento-enviado`
- `POST /api/processamentos/documento-vencendo`

## Executar local
```bash
cp appsettings.example.json appsettings.json
dotnet restore
dotnet run
```
