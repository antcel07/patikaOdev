const slider = document.getElementById("slider");
const slides = slider.getElementsByClassName("slide");
const captions = slider.getElementsByClassName("caption");
const prevButton = document.getElementById("prevButton");
const nextButton = document.getElementById("nextButton");

let currentSlideIndex = 0;

function showSlide(index) {
  // Mevcut slaytı gizle
  slides[currentSlideIndex].classList.remove("active");
  captions[currentSlideIndex].classList.remove("active");

  // Yeni slaytı göster
  slides[index].classList.add("active");
  captions[index].classList.add("active");

  // Güncel slayt indeksini güncelle
  currentSlideIndex = index;
}

prevButton.addEventListener("click", () => {
  // Önceki slayta git
  let prevSlideIndex = currentSlideIndex - 1;
  if (prevSlideIndex < 0) {
    prevSlideIndex = slides.length - 1;
  }
  showSlide(prevSlideIndex);
});

nextButton.addEventListener("click", () => {
  // Sonraki slayta git
  let nextSlideIndex = (currentSlideIndex + 1) % slides.length;
  showSlide(nextSlideIndex);
});

function startSlider() {
  showSlide(currentSlideIndex);

  setInterval(() => {
    let nextSlideIndex = (currentSlideIndex + 1) % slides.length;
    showSlide(nextSlideIndex);
  }, 5000);
}

startSlider();
