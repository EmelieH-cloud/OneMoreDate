function adjustForKeyboard() {
    window.addEventListener('resize', function () {
        if (document.activeElement.tagName === 'INPUT' || document.activeElement.tagName === 'TEXTAREA') {
            // Justera höjden på sidan när tangentbordet visas
            document.body.style.height = (window.innerHeight + 'px');
        } else {
            // Återställ höjden på sidan när tangentbordet göms
            document.body.style.height = '100vh';
        }
    });
}


