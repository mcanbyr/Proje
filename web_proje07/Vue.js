// Vue.js ile gönder butonuna tıklandığında yapılacaklar
const app = new Vue({
    el: '#contactForm',
    methods: {
        handleSubmitWithVue() {
            const name = this.$refs.name.value.trim();
            const email = this.$refs.email.value.trim();
            const phone = this.$refs.phone.value.trim();
            const message = this.$refs.message.value.trim();

            // Gerekli kontroller
            if (name === '') {
                alert('Lütfen isminizi giriniz.');
                return;
            }

            if (email === '') {
                alert('Lütfen e-posta adresinizi giriniz.');
                return;
            }

            if (!this.validateEmail(email)) {
                alert('Geçersiz e-posta formatı.');
                return;
            }

            if (phone === '') {
                alert('Lütfen telefon numaranızı giriniz.');
                return;
            }

            if (!this.validatePhoneNumber(phone)) {
                alert('Telefon numarası sadece rakamlardan oluşmalıdır.');
                return;
            }

            if (message === '') {
                alert('Lütfen bir mesaj giriniz.');
                return;
            }

            // Gönderme işlemi burada gerçekleştirilecek
            console.log('Vue.js ile gönderme işlemi');
        },
        validateEmail(email) {
            const re = /\S+@\S+\.\S+/;
            return re.test(email);
        },
        validatePhoneNumber(phone) {
            const re = /^\d+$/;
            return re.test(phone);
        },
        handleClearForm() {
            this.$refs.contactForm.reset();
            console.log('Form temizlendi');
        }
    }
});