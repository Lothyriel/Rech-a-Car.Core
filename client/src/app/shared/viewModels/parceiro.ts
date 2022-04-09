import { CupomListViewModel } from "./cupom";

export class ParceiroCreateViewModel {
    nome: string;
}

export class ParceiroDetailsViewModel {
    id: number;
    nome: string;
    cupons: CupomListViewModel[];
}

export class ParceiroEditViewModel {
    id: number;
    nome: string;
}

export class ParceiroListViewModel {
    id: number;
    nome: string;
}