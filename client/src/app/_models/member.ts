import { Photo } from "./photo";

export interface Member {
    id: number;
    userName: string;
    photoUrl: string;
    age: number;
    knownAs: string;
    created: string;
    lastActive: string;
    gender: string;
    country: string;
    city: string;
    interests: string;
    lookingFor: string;
    introduction: string;
    photos: Photo[];
}

