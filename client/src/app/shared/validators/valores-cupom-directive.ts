import { AbstractControl } from "@angular/forms";

export function valorMinimo(campo: AbstractControl) {
    const valor = campo.parent?.get('valor')?.value;
    const valorMinimo = campo.parent?.get('valorMinimo')?.value;

    if (parseInt(valorMinimo) >= parseInt(valor)) {
        return null; //sucesso
    } else {
        return { valorMenor: true }; //falha
    }
}