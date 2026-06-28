@import url('https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600&family=Space+Grotesk:wght@500;600&display=swap');

.tail-container {
    font-family: 'Inter', system_ui, sans-serif;
}

.logo-font {
    font-family: 'Space Grotesk', sans-serif;
}

.hero-bg {
    background-image: url('background.png');
    background-size: cover;
    background-position: center;
}

.hero-bg::before {
    content: '';
    position: absolute;
    inset: 0;
    background: linear-gradient(to bottom, rgba(0,0,0,0.65) 40%, rgba(0,0,0,0.92) 100%);
    transition: opacity 1.8s cubic-bezier(0.23, 1, 0.32, 1);
    z-index: 1;
}

.scroll-indicator {
    animation: scrollAnim 2s infinite;
}

@keyframes scrollAnim {
    0%, 100% { opacity: 1; }
    50% { opacity: 0.4; }
}

.nav-link {
    transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
}

.nav-link:hover {
    color: #00b4ff;
    transform: translateY(-1px);
}

.card {
    transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}

.card:hover {
    transform: translateY(-6px);
}

/* RESPONSIVE + PERFORMANCE */
@media (max-width: 768px) {
    .hero-bg h1 { font-size: 2.75rem; line-height: 1.1; }
    .hero-bg h2 { font-size: 2.25rem; line-height: 1.1; }
    .grid { grid-template-columns: 1fr; gap: 1.5rem; }
}

body { font-display: swap; }
img { image-rendering: crisp-edges; }
a { text-decoration: none; }