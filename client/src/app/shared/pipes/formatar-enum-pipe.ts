import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatarEnum'
})
export class FormatarEnumPipe implements PipeTransform {

  transform(textoEnum: string): string {
    var result = textoEnum.replace(/([A-Z])/g, " $1");
    var finalResult = result.charAt(0).toUpperCase() + result.slice(1);
    return finalResult;
  }

}