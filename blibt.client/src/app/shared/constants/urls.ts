//import { environment } from "src/environments/environment";

const BASE_URL = /*environment.production ? '' :*/ 'https://localhost:7148';


//models
export const AUTHORS_URL = BASE_URL + '/api/authors/';
export const AUTHORS_BY_SEARCH_URL = AUTHORS_URL + '/search/';
export const AUTHOR_BY_ID_URL = AUTHORS_URL + '/';

export const GENRES_URL = BASE_URL + '/api/genres/';
export const GENRES_BY_SEARCH_URL = GENRES_URL + '/search/';
export const GENRE_BY_ID_URL = GENRES_URL + '/';
export const GENRES_BY_BOOK_ID = GENRES_URL + '/GenresByBookId/';

export const BOOKS_URL = BASE_URL + '/api/books/';
export const BOOKS_TAGS_URL = BOOKS_URL + '/tags';
export const BOOKS_BY_SEARCH_URL = BOOKS_URL + '/search/';
export const BOOKS_BY_TAG_URL = BOOKS_URL + '/tag/';
export const BOOKS_BY_GENRE_ID = BOOKS_URL + '/BooksByGenreId/';
export const RND_BOOKS_FOR_BP = BOOKS_URL + 'rndBooks/';

//user
export const USER_LOGIN_URL = BASE_URL + '/api/authentication/login/';
export const USER_REGISTER_URL = BASE_URL + '/api/authentication/';
export const USER_FAVBOOKS_URL = BASE_URL + '/api/user/favBooks/';



//resousers
export const RESOURCES = BASE_URL + '/resources/'
