export class Nodo {
  nodo: Nodo
  x: number
  y: number
  cell_type: Cell
}

export enum Cell {
    WALL = 1,
    SHELF = 2,
    HALL = 3,
    INITIAL_POS = 4,
    DELIVER_POS = 5,
  }