import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lixoeletronico',
  templateUrl: './lixoeletronico.component.html',
  styleUrl: './lixoeletronico.component.css'
})
export class LixoEletronicoComponent implements OnInit {
  images: string[] = [
    '../../assets/images/tecnico.jpg',
    '../../assets/images/variedade.jpg',
    '../../assets/images/objetos.jpg'
  ];
  currentIndex: number = 0;
  currentImage: string = this.images[0];

  ngOnInit() {

    this.currentImage = this.images[0];

  }

  prevImage() {
    this.currentIndex = (this.currentIndex - 1 + this.images.length) % this.images.length;
    this.currentImage = this.images[this.currentIndex];
  }

  nextImage() {
    this.currentIndex = (this.currentIndex + 1) % this.images.length;
    this.currentImage = this.images[this.currentIndex];
  }
}

