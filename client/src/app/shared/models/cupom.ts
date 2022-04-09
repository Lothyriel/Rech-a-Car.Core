import { Parceiro } from "./parceiro";

export class Cupom {
    id: number;
    nome: string;
    valor: number;
    valorMinimo: number;
    dataValidade: Date;
    parceiro: Parceiro;
}