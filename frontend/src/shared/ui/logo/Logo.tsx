type LogoProps = {
    className?: string;
};

export const Logo = ({ className }: LogoProps) => (
    <svg
        className={className}
        style={{ width: '175px', height: '34.5px' }}
        width="352"
        height="69"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
        viewBox="0 0 352 69"
    >
        <path
            d="M.93 43.484c2.89 1.094 6.015 1.641 9.375 1.641 9.562 0 14.578-4.688 15.047-14.063H2.617v-2.109h22.758c-.36-9.062-5.383-13.594-15.07-13.594-3.36 0-6.485.547-9.375 1.641v-2.344c2.89-.937 6.015-1.406 9.375-1.406 11.718 0 17.578 5.508 17.578 16.523 0 11.641-5.86 17.461-17.578 17.461-3.36 0-6.485-.468-9.375-1.406v-2.344Zm35.297-21.093V47h-2.461V22.39h2.46ZM49.586 47l-3.445-5.766c-2.313-4.328-4.86-6.492-7.641-6.492v-1.476c2.969 0 5.023-1.813 6.164-5.438 1.156-3.625 3.281-5.437 6.375-5.437h1.805V24.5h-1.852c-1.844 0-3.242 1.422-4.195 4.266-.953 2.828-2.406 4.547-4.36 5.156 1.688.484 3.82 2.781 6.399 6.89L52.726 47h-3.14Zm6.21-12.305c0-8.36 3.907-12.539 11.72-12.539 7.812 0 11.718 4.18 11.718 12.54 0 8.359-3.906 12.538-11.718 12.538-7.782 0-11.688-4.18-11.72-12.539Zm2.462-.093c0 7.015 3.086 10.523 9.258 10.523 6.171 0 9.257-3.508 9.257-10.523 0-6.891-3.085-10.336-9.257-10.336s-9.258 3.445-9.258 10.336Zm37.617-.961v2.109H84.156v-2.11h11.719ZM101.898 47h-2.625l15.165-33.516h2.929L132.602 47h-2.93l-4.969-11.25H109.68l.726-2.11h13.383l-8.039-18.234L101.898 47Zm49.571.164c-10.469-.531-15.703-4.75-15.703-12.656 0-7.656 5.234-11.75 15.703-12.281v-8.743h2.437v8.72c10.469.483 15.703 4.585 15.703 12.304 0 7.969-5.234 12.195-15.703 12.68v8.718h-2.437v-8.742Zm0-2.133V24.36c-8.688.516-13.031 3.93-13.031 10.243 0 6.421 4.343 9.898 13.031 10.43Zm2.437-20.695v20.719c8.688-.47 13.032-3.953 13.032-10.453 0-6.375-4.344-9.797-13.032-10.266ZM193.047 47V25.625L177.93 47h-2.461V22.39h2.226v21.376l15.117-21.375h2.461V47h-2.226Zm9.281 0V22.39h2.461v22.5h11.016v-22.5h2.461v22.5h11.015v-22.5h2.461V47h-29.414Zm35.297-6.96c0-4.892 3.25-7.337 9.75-7.337 2.297 0 4.75.156 7.359.469v-3.024c0-3.765-2.367-5.648-7.101-5.648-2.531 0-5.125.39-7.781 1.172v-2.11c2.656-.78 5.25-1.171 7.781-1.171 6.375 0 9.562 2.547 9.562 7.64V47h-1.5l-.562-2.438C252.055 46.188 249.07 47 246.18 47c-5.703 0-8.555-2.32-8.555-6.96Zm9.75-5.227c-4.859 0-7.289 1.718-7.289 5.156 0 3.281 2.031 4.922 6.094 4.922 3 0 5.851-.797 8.554-2.391v-7.219c-2.609-.312-5.062-.468-7.359-.468Z"
            fill="#000"
        />
        <g clip-path="url(#a)">
            <path
                d="M316.006 52.973c15.41 0 26.679-10.35 35.994-18.4-9.315-8.049-20.586-18.399-35.994-18.399-14.49 0-18.285 10.695-20.355 17.25H283v2.3h12.651c2.07 6.556 5.865 17.25 20.355 17.25v-.001Zm-17.94-17.25h8.97l7.245 7.245 1.61-1.611-5.634-5.634h23.346v-2.301h-11.04l5.979-5.98-1.611-1.61-7.59 7.59h-21.275c2.07-6.324 5.634-14.95 17.94-14.95 13.455 0 23.574 8.395 32.43 16.101-8.856 7.705-18.975 16.101-32.43 16.101-12.306 0-15.87-8.627-17.94-14.951Z"
                fill="#000"
            />
        </g>
        <defs>
            <clipPath id="a">
                <path
                    fill="#fff"
                    transform="rotate(90 176 176)"
                    d="M0 0h69v69H0z"
                />
            </clipPath>
        </defs>
    </svg>
);
