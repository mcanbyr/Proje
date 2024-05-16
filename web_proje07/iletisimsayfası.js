function handleSubmitWithJS(event) {
    event.preventDefault(); // Formun varsayılan davranışını engelle

    // Form elemanlarını seç
    const nameInput = document.getElementById('name');
    const emailInput = document.getElementById('email');
    const phoneInput = document.getElementById('phone');
    const messageInput = document.getElementById('message');
    const jobStatusInput = document.querySelector('input[name="jobStatus"]:checked');
    const genderSelect = document.getElementById('gender');
    const birthDateInput = document.getElementById('birthDate');

    // İsim alanı boş mu kontrol et
    if (nameInput.value.trim() === '') {
        alert('Lütfen isminizi girin');
        return;
    }

    // E-posta alanı boş mu ve geçerli bir e-posta mı kontrol et
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (emailInput.value.trim() === '' || !emailPattern.test(emailInput.value.trim())) {
        alert('Lütfen geçerli bir e-posta adresi girin');
        return;
    }

    // Telefon alanı boş mu ve sadece rakamlardan oluşuyor mu kontrol et
    const phonePattern = /^\d+$/;
    if (phoneInput.value.trim() !== '' && !phonePattern.test(phoneInput.value.trim())) {
        alert('Telefon numarası sadece rakamlardan oluşmalıdır');
        return;
    }

    // Mesaj alanı boş mu kontrol et
    if (messageInput.value.trim() === '') {
        alert('Lütfen bir mesaj girin');
        return;
    }

    // İş durumu seçilmiş mi kontrol et
    if (!jobStatusInput) {
        alert('Lütfen iş durumunuzu seçin');
        return;
    }

    // Cinsiyet seçilmiş mi kontrol et
    if (genderSelect.value === 'belirtmek istemiyorum') {
        alert('Lütfen cinsiyetinizi seçin');
        return;
    }

    // Doğum tarihi seçilmiş mi kontrol et
    if (birthDateInput.value === '') {
        alert('Lütfen doğum tarihinizi seçin');
        return;
    }

    // Formu gönder
    document.getElementById('contactForm').submit();

}

function handleClearForm() {
    // Form elemanlarını seç
    const nameInput = document.getElementById('name');
    const emailInput = document.getElementById('email');
    const phoneInput = document.getElementById('phone');
    const messageInput = document.getElementById('message');
    const jobStatusInputs = document.querySelectorAll('input[name="jobStatus"]');
    const genderSelect = document.getElementById('gender');
    const birthDateInput = document.getElementById('birthDate');

    // Form elemanlarının değerlerini temizle
    nameInput.value = '';
    emailInput.value = '';
    phoneInput.value = '';
    messageInput.value = '';
    jobStatusInputs.forEach(input => input.checked = false); // İş durumu radio butonlarını temizle
    genderSelect.value = 'belirtmek istemiyorum';
    birthDateInput.value = '';
}




new Vue({
    el: '#app',
    methods: {
        handleSubmitWithVue: function(event) {
            event.preventDefault(); // Formun varsayılan davranışını engelle

            // Form verilerini al
            const formData = new FormData(document.getElementById('contactForm'));

            // İsim alanı boş mu kontrol et
            if (!formData.get('name')) {
                alert('Lütfen isminizi girin');
                return;
            }

            // E-posta alanı boş mu ve geçerli bir e-posta mı kontrol et
            const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            if (!formData.get('email') || !emailPattern.test(formData.get('email'))) {
                alert('Lütfen geçerli bir e-posta adresi girin');
                return;
            }

            // Telefon alanı boş mu ve sadece rakamlardan oluşuyor mu kontrol et
            const phonePattern = /^\d+$/;
            if (formData.get('phone') && !phonePattern.test(formData.get('phone'))) {
                alert('Telefon numarası sadece rakamlardan oluşmalıdır');
                return;
            }

            // Mesaj alanı boş mu kontrol et
            if (!formData.get('message')) {
                alert('Lütfen bir mesaj girin');
                return;
            }

            // İş durumu seçilmiş mi kontrol et
            if (!formData.get('jobStatus')) {
                alert('Lütfen iş durumunuzu seçin');
                return;
            }

            // Cinsiyet seçilmiş mi kontrol et
            if (formData.get('gender') === 'belirtmek istemiyorum') {
                alert('Lütfen cinsiyetinizi seçin');
                return;
            }

            // Doğum tarihi seçilmiş mi kontrol et
            if (!formData.get('birthDate')) {
                alert('Lütfen doğum tarihinizi seçin');
                return;
            }

            // Formu gönder
            document.getElementById('contactForm').submit();
        }
    }
});
