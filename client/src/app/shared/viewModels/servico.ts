import { CupomListViewModel } from "./cupom";

export class ServicoCreateViewModel {
    nome: string;
}

export class ServicoDetailsViewModel {
    id: number;
    nome: string;
    cupons: CupomListViewModel[];
}

export class ServicoEditViewModel {
    id: number;
    nome: string;
}

export class ServicoListViewModel {
    id: number;
    nome: string;
}