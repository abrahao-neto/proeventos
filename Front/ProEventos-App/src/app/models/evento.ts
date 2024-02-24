import { Lote } from "./lote";
import { Palestrante } from "./palestrante";
import { RedeSocial } from "./rede-social";

export interface Evento {
    id: number;
    local: string;
    dataEvento?: Date;
    tema: string; 
    qtdPessoas: number; 
    imagemURL: string; 
    telefone: string; 
    Email: string; 
    lotes: Lote[]; 
    redesSociais?: RedeSocial; 
    palestrantesEventos?: Palestrante[]; 

}