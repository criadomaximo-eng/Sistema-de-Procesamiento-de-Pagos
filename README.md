# Sistema de Procesamiento de Pagos

## Descripción

Aplicación de consola desarrollada en C# para procesar distintos métodos de pago utilizados por los clientes de una empresa.

El sistema permite registrar pagos, mostrar la información de cada operación, procesar transacciones, calcular comisiones según el método de pago utilizado y mostrar el monto final de cada operación.

## Estructura

### Pago

Clase base que contiene los datos comunes de todos los métodos de pago:

* Titular
* Monto

Métodos implementados:

* ProcesarPago()
* CalcularComision()

### Tarjeta de Crédito

Clase que hereda de Pago y representa los pagos realizados con tarjeta de crédito.

Implementa su propia lógica para procesar la operación y calcular las comisiones correspondientes.

### Transferencia Bancaria

Clase que hereda de Pago y representa los pagos realizados mediante transferencia bancaria.

Implementa un comportamiento específico para el procesamiento del pago y el cálculo de cargos adicionales.

## Funcionalidades

* Registrar distintos métodos de pago.
* Mostrar información de cada operación.
* Procesar pagos.
* Calcular comisiones según el método utilizado.
* Mostrar el monto final de la transacción.
* Aplicar comportamientos específicos para cada tipo de pago.

## Conceptos aplicados

* Programación Orientada a Objetos (POO)
* Herencia
* Polimorfismo
* Encapsulamiento
* Reutilización de código
* Uso de listas (`List<Pago>`)

## Tecnologías utilizadas

* C#
* .NET
* Aplicación de Consola

## Autor

* Máximo Criado
* Agustín Bosaz
