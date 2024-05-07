//import { environment } from "src/environments/environment";

const BASE_URL = /*environment.production ? '' :*/ 'https://localhost:7148';


//models
export const AUTHORS_URL = BASE_URL + '/api/authors/';
export const AUTHORS_BY_SEARCH_URL = AUTHORS_URL + '/search/';
export const AUTHOR_BY_ID_URL = AUTHORS_URL;

export const GENRES_URL = BASE_URL + '/api/genres/';
export const GENRES_BY_SEARCH_URL = GENRES_URL + '/search/';
export const GENRE_BY_ID_URL = GENRES_URL;
export const GENRES_BY_BOOK_ID = GENRES_URL + 'GenresByBookId/';

export const BOOKS_URL = BASE_URL + '/api/books/';
export const BOOKS_BY_GENRE_ID = BOOKS_URL + 'BooksByGenreId/';
export const RND_BOOKS_FOR_BP = BOOKS_URL + 'rndBooks/';
export const BOOKS_ALL = BOOKS_URL + 'all/';

//user
export const USER_LOGIN_URL = BASE_URL + '/api/authentication/login/';
export const USER_REGISTER_URL = BASE_URL + '/api/authentication/registration/';
export const USER_FAVBOOKS_URL = BASE_URL + '/api/user/favBooks/';
export const USER_LIKEDBOOKS_URL = BASE_URL + '/api/user/likedBooks/';
export const USER_SETFAV_URL = BASE_URL + '/api/user/addFavorite/';
export const USER_SETLIKE_URL = BASE_URL + '/api/user/addLike/';
export const USER_ISLIKEDCHECK_URL = BASE_URL + '/api/user/isLiked/';
export const USER_ISFAVORITECHECK_URL = BASE_URL + '/api/user/isFavotite/';
export const USER_REMOVE_LIKE = BASE_URL + '/api/user/removeLikedBook/';
export const USER_REMOVE_FAVORITE_URL = BASE_URL + '/api/user/removeFavoriteBook/';
export const USER_GET_BUYED_BOOKS_URL = BASE_URL + '/api/user/buyedBooks/';
export const USER_ADD_VIEW_TO_BOOK = BASE_URL + '/api/user/addView/';

export const TRANSACTIONS_URL = BASE_URL + '/api/transactions/'; 



//resousers
export const RESOURCES = BASE_URL + '/resources/'
