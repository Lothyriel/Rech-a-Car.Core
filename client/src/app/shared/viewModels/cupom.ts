export class CupomCreateViewModel {
    parceiroId: number;
    nome: string;
    valor: number;
    datavalidade: Date;
    valorMinimo: number;
    tipo: number;
}
export class CupomDetailsViewModel {
    id: number;
    parceiroId: number;
    nome: string;
    valor: number;
    dataValidade: Date;
    valorMinimo: number;
    tipo: number;
}
export class CupomEditViewModel {
    id: number;
    parceiroId: number;
    nome: string;
    valor: number;
    datavalidade: Date;
    valorMinimo: number;
    tipo: number;
}
export class CupomListViewModel {
    id: number;
    nome: string;
    parceiroNome: string;
    dataValidade: Date;
    valor: number;
    valorMinimo: number;
    tipo: string;
}