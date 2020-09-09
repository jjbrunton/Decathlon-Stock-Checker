# Decathlon-Stock-Checker

## Example Usage

### Request

http://{IP}:{PORT}/api/Stock/S?urlSuffix=p/recreational-cycling-road-bike-triban-rc520-disc-brakes/_/R-p-308072

### Response
```
{
    "variant": "S",
    "inStock": false
}
```

### Request

http://{IP}:{PORT}/api/Stock?urlSuffix=p/recreational-cycling-road-bike-triban-rc520-disc-brakes/_/R-p-308072

Only in stock variants are returned when a variant isn't specified in the path.

### Response
```
{
    "variant": "XS,S,XL",
    "inStock": true
}
```