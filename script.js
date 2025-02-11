window.onscroll = function() {
    const bioSection = document.getElementById('bioSection');
    const linksSection = document.getElementById('linksSection');
    const bioBtn = document.getElementById('bioBtn');
    const linksBtn = document.getElementById('linksBtn');

    const bioSectionTop = bioSection.offsetTop;
    const linksSectionTop = linksSection.offsetTop;

    if (window.scrollY >= bioSectionTop && window.scrollY < linksSectionTop) {
        bioBtn.classList.add('active');
        linksBtn.classList.remove('active');
    } else if (window.scrollY >= linksSectionTop) {
        linksBtn.classList.add('active');
        bioBtn.classList.remove('active');
    } else {
        bioBtn.classList.remove('active');
        linksBtn.classList.remove('active');
    }
};
