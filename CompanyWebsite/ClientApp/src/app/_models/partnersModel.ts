export interface PartnerModel {
  id: number;
  name: string;
  biography: string;
  userName: string;
  photoUrl: string;
  photos: Photo[];
}

export interface Photo {
  id: number;
  url: string;
  isMain: boolean;
}
