# Prova Prática 2022251 - Julio Araujo

Este projeto tem:

- Terra e lua como plano
- Lua a orbitar a terra
- Tres botoes para trocar entre as tres cameras

- **General camera** Plano Geral
- **Earth camera** Focado na terra
- **Moon camera** Focado na Lua
- `CameraController` gere as transiçoes

## Controls

Troca de cameras usando os tres botoes:

- Vista geral
- Vista da terra
- Vista da lua
  
## Como Funciona

O script 'CameraController' mantém três câmaras virtuais na cena e altera a sua prioridade quando um botão é pressionado. A câmara ativa recebe a prioridade mais alta, por isso o Cinemachine mostra essa visão.

Para além deste existe também o MoonController, que gere a orbita da Lua, a qual pode ser manipulada no próprio editor
